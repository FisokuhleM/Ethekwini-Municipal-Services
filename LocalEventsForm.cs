using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10229540_PROG7312_POE
{
    public partial class LocalEventsForm : MaterialForm
    {
        // Globals
        private SortedDictionary<DateTime, List<Event>> eventDictionary = new SortedDictionary<DateTime, List<Event>>();
        private EventsRecommendation eventsRecommendation = new EventsRecommendation(); // Global instance of EventsRecommendation
        private HashSet<string> categories = new HashSet<string>();

        public LocalEventsForm()
        {
            InitializeComponent();

            // Use the existing DateTimePicker (dateTimePicker1)
            dateTimePicker1.Value = DateTime.Now;  // Set initial date to today's date

            LoadEvents();
            SeedEvents();

            categories.Add("Select a Category");
            categories.Add("Sports");
            categories.Add("Cultural");
            categories.Add("Educational");
            CategoriesComboBox.Items.AddRange(categories.ToArray());
            CategoriesComboBox.SelectedIndex = 0;  // Set default selection to "Select a Category"

            DisplayAllEvents();  // Display all events by default
            UpdateRecommendations();
        }

        private void LoadEvents()
        {
            // You can add any logic to load events here if needed.
        }

        private void AddEvent(Event newEvent)
        {
            if (!eventDictionary.ContainsKey(newEvent.Date))
            {
                eventDictionary[newEvent.Date] = new List<Event>();
            }
            eventDictionary[newEvent.Date].Add(newEvent);
        }

        private void SeedEvents()
        {
            // Adding sample sports, cultural, and educational events
            AddEvent(new Event("Local Marathon", "Sports", DateTime.Now.AddDays(10), "City Park"));
            AddEvent(new Event("Basketball Tournament", "Sports", DateTime.Now.AddDays(15), "Sports Arena"));
            AddEvent(new Event("Swimming Competition", "Sports", DateTime.Now.AddDays(20), "Aquatic Center"));
            AddEvent(new Event("Tennis Open", "Sports", DateTime.Now.AddDays(25), "Tennis Club"));
            AddEvent(new Event("Cycling Race", "Sports", DateTime.Now.AddDays(30), "City Streets"));

            AddEvent(new Event("Art Exhibition", "Cultural", DateTime.Now.AddDays(5), "City Gallery"));
            AddEvent(new Event("Theater Performance", "Cultural", DateTime.Now.AddDays(12), "Community Theater"));
            AddEvent(new Event("Music Festival", "Cultural", DateTime.Now.AddDays(18), "Central Park"));
            AddEvent(new Event("Food and Wine Fair", "Cultural", DateTime.Now.AddDays(22), "Convention Center"));
            AddEvent(new Event("Film Festival", "Cultural", DateTime.Now.AddDays(28), "Cinema Complex"));

            AddEvent(new Event("Science Fair", "Educational", DateTime.Now.AddDays(7), "Science Museum"));
            AddEvent(new Event("History Lecture Series", "Educational", DateTime.Now.AddDays(14), "Public Library"));
            AddEvent(new Event("Coding Workshop", "Educational", DateTime.Now.AddDays(21), "Tech Hub"));
            AddEvent(new Event("Environmental Seminar", "Educational", DateTime.Now.AddDays(26), "Botanical Gardens"));
            AddEvent(new Event("Career Expo", "Educational", DateTime.Now.AddDays(32), "University Campus"));
        }

        private void DisplayAllEvents()
        {
            EventsListBox.Items.Clear();
            foreach (var eventList in eventDictionary.Values)
            {
                foreach (var ev in eventList)
                {
                    EventsListBox.Items.Add($"{ev.Date.ToShortDateString()} - {ev.Name} ({ev.Category} at {ev.Location})");
                }
            }
        }


        private void UpdateRecommendations()
        {
            string topCategory = eventsRecommendation.RecommendCat();

            listBoxRecommendations.Items.Clear();

            if (string.IsNullOrEmpty(topCategory))
            {
                listBoxRecommendations.Items.Add("No recommendations available yet.");
                return;
            }

            listBoxRecommendations.Items.Add($"Recommended category: {topCategory}");

            var currentDate = DateTime.Now.Date;
            var recommendedEvents = eventDictionary.SelectMany(en => en.Value)
                .Where(ev => ev.Category.Equals(topCategory, StringComparison.OrdinalIgnoreCase))
                .OrderBy(ev => Math.Abs((ev.Date.Date - currentDate).TotalDays))  // Sort by closest date
                .Take(2)  // Limit to 2 events
                .ToList();

            foreach (var ev in recommendedEvents)
            {
                listBoxRecommendations.Items.Add($"{ev.Date.ToShortDateString()} - {ev.Name} at {ev.Location}");
            }
        }

        private void SearchButton_Click_2(object sender, EventArgs e)
        {
            var selectedCategory = CategoriesComboBox.SelectedItem?.ToString();
            var selectedDate = dateTimePicker1.Value.Date;

            if (selectedCategory == "Select a Category")
            {
                // Display all events from all categories
                var allEvents = eventDictionary
                    .SelectMany(entry => entry.Value)
                    .OrderBy(ev => ev.Date)
                    .ToList();

                DisplayFilteredEvents(allEvents);
            }
            else
            {
                // Track the recommended events based on category
                eventsRecommendation.TrackSearch(selectedCategory);

                // Filter events based on both category and selected date
                var filteredEvents = eventDictionary
                    .Where(entry => entry.Key.Date == selectedDate)
                    .SelectMany(entry => entry.Value)
                    .Where(ev => ev.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                DisplayFilteredEvents(filteredEvents);
            }

            // Update recommendations immediately after the search
            UpdateRecommendations();
        }

        private void DisplayFilteredEvents(List<Event> events)
        {
            EventsListBox.Items.Clear();
            if (events.Count == 0)
            {
                EventsListBox.Items.Add("No events found for the selected criteria.");
            }
            else
            {
                foreach (var ev in events)
                {
                    EventsListBox.Items.Add($"{ev.Date.ToShortDateString()} - {ev.Name} ({ev.Category} at {ev.Location})");
                }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }
    }
}