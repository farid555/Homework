namespace exercise_123 {
    public class Counter {
        public int value { get; set; }
       

        // set value of counter
        public Counter (int startValue) {
            this.value = startValue;
        }

        public Counter() {
            this.value = 0;
        }
        // increase value
        public void Increase() {
            this.value++;
        }
        // decrease value
        public void Decrease() {
            this.value--;
        }
        public void Increase(int increaseBy) {
            if (increaseBy > 0) {
                this.value = this.value + increaseBy;
            }
        }
        public void Decrease(int decreaseby) {
            if (decreaseby > 0) {
                this.value = this.value - decreaseby;
            }
        }
    }

}